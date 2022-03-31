import { NavigationGuardNext, RouteLocationNormalized } from "vue-router";

export const setPageTitle = (
  to: RouteLocationNormalized,
  _: RouteLocationNormalized,
  next: NavigationGuardNext
) => {
  document.title = `${String(to.name)} :: OfCourse`;
  next();
};
