<template>
  <div>
    <the-header></the-header>
    <main>
      <slot />
    </main>
    <the-footer></the-footer>
  </div>
</template>

<script>
import TheHeader from "@/components/layout/TheHeader.vue";
import TheFooter from "@/components/layout/TheFooter.vue";
export default {
  components: {
    TheHeader,
    TheFooter,
  },
};
</script>

<style lang="scss" scoped></style>
