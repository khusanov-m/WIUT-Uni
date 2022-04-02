<template>
  <default-layout>
    <router-view />
  </default-layout>
</template>

<script>
import DefaultLayout from "@/layouts/Default.vue";
export default {
  components: {
    DefaultLayout,
  },
};
</script>

<style lang="scss">
@import "@/styles/variables.scss";

#app {
  
}

a {
  font-weight: 400;
  color: $font-color-04;

  &.router-link-exact-active {
    font-weight: 600;
    color: $font-color-07;
  }
}
</style>
