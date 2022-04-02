import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import axios from "axios";
import VueAxios from "vue-axios";

const app = createApp(App);

// SASS Styles //
import "@/styles/style.scss";

axios.defaults.baseURL = "https://wiut00011883.herokuapp.com/api/v1/";

app.use(router).use(VueAxios, axios).mount("#app");
