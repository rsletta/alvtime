<template>
  <div class="entry">  
    <div v-if="!expanded" class="entry-small" v-on:click="expandEntryToggle">
      <p class="customer-name">{{ task.project.customer.name }} - {{ task.project.name }} super duper hurra super duper hurra super duper hurra super duper hurra</p>
      <!-- <p class="customer-name">{{ task.project.name }}</p> -->
      <div class="activity-name-container">
        <span class="activity-name">{{ task.name }} super duper hurra super duper hurra super duper hurra super duper hurra</span>
        <small class="rate-text">{{ compensationRatePercentage }}</small>
      </div>
    </div>
    <div v-if="expanded" class="entry-expanded" v-on:click="expandEntryToggle">
      <label>
        Kunde:
      <span class="entryText">{{ task.project.customer.name }}</span>
      </label>
      <label>
          Prosject:
      <span class="entryText">{{ task.project.name }} super duper hurra super duper hurra super duper hurra super duper hurra</span>
      </label>
      <label>
      Aktivitet:
      <span class="entryText activity-name">{{ task.name }} super duper hurra super duper hurra super duper hurra super duper hurra</span>
      </label>
      <label>
        Rate:
      <small class="entryText">{{ compensationRatePercentage }}</small>
      </label>  
    </div>
      <div v-show="showPadlock" class="padlock">
        <md-icon class="icon">lock</md-icon>
      </div>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import { Task } from "@/store/tasks";

export default Vue.extend({
  data() {
    return {
      expanded: false
    }
  },
  props: {
    task: {
      type: Object as () => Task,
      default: (): Task => {
        return {} as Task;
      },
    },
  },
  methods: {
    expandEntryToggle() {
      this.expanded = !this.expanded
    }
  },
  computed: {
    compensationRatePercentage(): string {
      return `${this.task.compensationRate * 100}%`;
    },
    showPadlock(): boolean {
      return this.task.locked;
    },
  },
});
</script>

<style scoped>
.entry {
  white-space: nowrap;
  overflow: hidden;
  font-size: 0.8rem;
  display: grid;
  grid-template-columns: 1fr 30px;
}

label {
  display: block;
  font-weight: 600;
  font-size: 0.6rem;
}

.entryText {
  font-weight: normal;
  font-size: 0.7rem;
}

.customer-name {
  margin: 0;
  font-size: 0.6rem;

  width: calc(90%);
  display: inline-block;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

.activity-name-container {
  display: flex;

  /* Prevent percentage values from touching the hour input */
  padding-right: 0.5rem;
  float: left;
}

.activity-name {
  font-weight: 600;
  margin: 0;

  width: calc(90%);
  display: inline-block;
  white-space: nowrap;
  overflow: hidden;
  text-overflow: ellipsis;
}

.rate-text {
  font-weight: lighter;
  margin-left: 0.25rem;
}

.padlock.expanded {
  margin-right: 0.4rem;
  float: right;
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
}

.padlock {
  display: grid;
}

.icon {
  justify-self: center;
}

</style>
