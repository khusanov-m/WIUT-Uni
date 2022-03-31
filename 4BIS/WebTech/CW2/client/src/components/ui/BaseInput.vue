<template>
  <div class="form__input">
    <label :for="purpose" v-if="tip">{{ tip }}</label>
    <input
      :type="text"
      :placeholder="example"
      :id="purpose"
      :value="init"
      :checked="boolean"
      :v-model="bind"
    />
  </div>
</template>

<script lang="ts">
// https://vuejs.org/guide/components/events.html#usage-with-v-model
export default {
  data() {
    return {
      author: "",
      coverImg: "",
      description: "",
      duration: "",
      price: "",
      title: "",
      isFavorite: false,
    };
  },
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
    boolean: {
      type: Boolean,
      default: false,
    },
    data: {
      type: String,
      default: "",
    },
    bind: {
      type: String,
      default: "",
    }
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
