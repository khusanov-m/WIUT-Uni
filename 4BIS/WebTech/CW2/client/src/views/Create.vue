<template lang="">
  <div>
    <p>CREATE</p>
    <form>
      <base-input
        v-for="(field, i) in fields"
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
<script>
export default {
  data() {
    return {
      fields: [
        {
          tip: "Title",
          purpose: "title",
          text: "text",
          example: "VueJS 3 Bootcamp 2022",
          init: "",
        },
        {
          tip: "Description",
          purpose: "description",
          text: "text",
          example:
            "In this course, you will learn how to build a VueJS 3 application",
          init: "",
        },
        {
          tip: "Cover Image",
          purpose: "coverImg",
          text: "text",
          example: "url.com/image.jpg",
          init: "",
        },
        {
          tip: "Author",
          purpose: "author",
          text: "text",
          example: "Jonas Schmedtmann",
          init: "",
        },
        {
          tip: "Price ($)",
          purpose: "price",
          text: "number",
          example: "199",
          init: "",
        },
        {
          tip: "Duration (in hours)",
          purpose: "duration",
          text: "number",
          example: "12",
          init: "",
        },
        {
          tip: "Is it your favourite?",
          purpose: "isFavourite",
          text: "checkbox",
          example: "",
          init: "",
        },
        {
          tip: "",
          purpose: "submit",
          text: "submit",
          example: "",
          init: "Create",
        },
      ],
    };
  },
};
</script>
<style lang=""></style>
