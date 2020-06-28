<template>
  <div class="container">
    <h1>Places</h1>
    <button v-on:click="getPlace">Click me</button>
    <div v-text="name"></div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "Places",
  data() {
    return {
      name: ""
    };
  },
  methods: {
    getPlace() {
      axios.get("/api/PlaceApi/GetPlace").then(response => (this.name = response.data.name));
    }
  }
};
</script>

<style scoped>
</style>
