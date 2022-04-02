<template>
  <footer class="footer">
    <p>
      This web application was created by <span> 00011883 </span> to fulfill Web
      Technology module's requirements and does not represent an actual company
      or service
    </p>
  </footer>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
@import "@/styles/variables.scss";

.footer {
  background: $font-color-01;
  padding: 3rem;
  display: flex;
  text-align: center;
  justify-content: center;

  span {
    color: $font-color-09;
  }
}
</style>
