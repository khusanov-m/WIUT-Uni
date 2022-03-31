<template>
  <div class="form__input">
    <label :for="purpose" v-if="tip">{{ tip }}</label>
    <input :type="text" :placeholder="example" :id="purpose" :value="init" />
  </div>
</template>

<script>
export default {
  props: {
    purpose: {
      type: String,
    },
    text: {
      type: String,
      default: "text",
    },
    example: {
      type: String,
      default: "",
    },
    init: {
      type: String || Boolean,
      default: "",
    },
    tip: {
      type: String,
      default: "",
    },
  },
};
</script>

<style lang="scss">
.form__input {
  display: flex;
  align-items: center;
  border: 2px solid rgba(255, 255, 255, 0.3);

  &:not(:last-child) {
    margin-bottom: 20px;
  }

  label {
    margin-right: 0.5rem;
  }
}
</style>
