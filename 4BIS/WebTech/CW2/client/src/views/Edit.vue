<template lang="">
  <div>
    <p>EDIT</p>

    <form>
      <base-input
        v-for="(field, i) of courses"
        :key="i"
        :tip="field.tip"
        :purpose="field.purpose"
        :text="field.text"
        :example="field.example"
        :init="field.init"
      ></base-input>
    </form>
  </div>
</template>

<script lang="ts">
import axios from "axios";

export default {
  data() {
    return {
      courses: {},
    };
  },
  methods: {
    async getCourse(): Promise<void> {
      try {
        const result = await axios.get(`/courses/${this.$route.params.id}`);
        const { data: { data } } = result;
        this.courses = data;
        console.log(this.courses);
      } catch (err) {
        console.log(err);
      }
    },
  },
  beforeMount(): void {
    this.getCourse();
  },
};
</script>

<style lang=""></style>
