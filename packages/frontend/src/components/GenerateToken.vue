<template>
  <div>
    <div class="description">
      Personlige access token fungerer akkurat som OAuth tilgangstokenerfor å
      autentisere deg mot alvtime web api. Bruk de som bearer tokens i
      applikasjoner der det ikke er mulig eller praktisk å implementere login
      mot Azure Ad.
    </div>
    <div class="container">
      <Input v-model="friendlyName" placeholder="Hva skal tokenet brukes til" />
      <YellowButton
        icon-id="add_circle_outline"
        :text="buttonText"
        :disabled="friendlyName.length < 1"
        @click="onGenereateTokenClick"
      />
    </div>
    <div v-if="showToken">
      <div class="info-text">
        Husk å kopier tokenet. Det vil ikke bli vist igjen.
      </div>
      <div class="token">
        <div>
          <span>{{ token }}</span>
          <span class="expires">expires: {{ expires }}</span>
        </div>
        <md-button class="icon_button" @click="onCopyClick">
          <md-icon class="icon">file_copy</md-icon>
          <Tooltip text="Copy access token" />
        </md-button>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import YellowButton from "./YellowButton.vue";
import Tooltip from "./Tooltip.vue";
import Input from "./Input.vue";
import config from "@/config";
import httpClient from "../services/httpClient";

export default Vue.extend({
  components: {
    YellowButton,
    Tooltip,
    Input,
  },

  data() {
    return {
      token: "",
      expires: "",
      friendlyName: "",
    };
  },

  computed: {
    buttonText(): string {
      // @ts-ignore
      return this.$mq === "sm" ? "" : "Lag nytt token";
    },

    showToken(): boolean {
      return !!this.token;
    },
  },

  methods: {
    onGenereateTokenClick() {
      this.fetchAccessToken();
    },

    onCopyClick() {
      const text = this.token.split(" ")[0];
      this.$copyText(text);
    },

    async fetchAccessToken() {
      httpClient
        .post<{ token: string; expires: string }>(
          `${config.API_HOST}/api/user/AccessToken`,
          { friendlyName: this.friendlyName }
        )
        .then(response => {
          this.token = response.data.token;
          this.expires = response.data.expires;
        })
        .catch(e => {
          console.error(e);
          this.$store.commit("ADD_TO_ERROR_LIST", e);
        });
    },
  },
});
</script>

<style scoped>
.container {
  display: grid;
  grid-template-columns: 1fr auto;
  align-items: center;
  padding-left: 1rem;
  padding-right: 1rem;
  max-width: 50rem;
}

.token {
  display: grid;
  grid-template-columns: auto 50px;
  align-items: center;
  align-content: center;
  border: 1px solid #00083d;
  background-color: #008dcf40;
  padding: 0.5rem;
  padding-right: 0;
  margin-top: 0.5rem;
  margin-left: 1rem;
  margin-right: 1rem;
}

@media only screen and (min-width: 510px) {
  .token {
    height: 2rem;
  }
}

.info-text {
  margin: 0.5rem 1rem;
}

.expires {
  margin-left: 1rem;
  font-weight: bold;
}

.icon_button {
  min-width: 1.5rem !important;
}

.description {
  margin: 0.5rem 1rem;
  max-width: 48rem;
}
</style>
