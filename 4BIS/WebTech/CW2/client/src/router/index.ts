import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import { setPageTitle } from "@/router/middlewares";
import Home from "@/views/Home.vue";
import Create from "@/views/Create.vue";
import Edit from "@/views/Edit.vue";
import Favourite from "@/views/Favourite.vue";
import Error from "@/views/Error.vue";

const routes: Array<RouteRecordRaw> = [
  {
    path: "/",
    name: "Home",
    component: Home,
  },
  {
    path: "/home",
    redirect: "/",
  },
  {
    path: "/edit/:id",
    name: "Edit",
    component: Edit,
  },
  {
    path: "/create",
    name: "Create",
    component: Create,
  },
  {
    path: "/add",
    redirect: "/create",
  },
  {
    path: "/favourite",
    name: "Favourite",
    component: Favourite,
  },
  {
    path: "/fav",
    redirect: "/favourite",
  },
  {
    path: "/favs",
    redirect: "/favourite",
  },
  {
    path: "/:pathMatch(.*)*",
    name: "Not Found",
    component: Error,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach(setPageTitle);

export default router;
