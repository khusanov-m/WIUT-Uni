import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import axios from "axios";
import VueAxios from "vue-axios";

const app = createApp(App);

// Slots //
import BaseInput from "@/components/ui/BaseInput.vue";

// Slots Component //
app.component("BaseInput", BaseInput);

// SASS Styles //
import "@/styles/style.scss";

// Icons //
import "material-design-icons-iconfont/dist/material-design-icons.css";

axios.defaults.baseURL = "http://localhost:5000/api/v1/";

app.use(router).use(VueAxios, axios).mount("#app");
