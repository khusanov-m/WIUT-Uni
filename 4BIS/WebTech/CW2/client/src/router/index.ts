import { createRouter, createWebHistory, RouteRecordRaw } from "vue-router";
import { setPageTitle } from "@/router/middlewares";
import Home from "@/views/Home.vue";
import Create from "@/views/Create.vue";
import Edit from "@/views/Edit.vue";
import Favourite from "@/views/Favourite.vue";

const routes: Array<RouteRecordRaw> = [
  {
    path: "/",
    name: "Home",
    component: Home,
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
    path: "/favourite",
    name: "Favourite",
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: Favourite,
  },
];

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach(setPageTitle);

export default router;
