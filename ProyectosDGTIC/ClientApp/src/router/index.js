import Vue from 'vue'
import VueRouter from 'vue-router'
import Login from '@/components/Login.vue'
// import FetchData from "@/components/FetchData.vue"
import Register from "@/components/Register.vue"
import Dashboard from "@/components/Dashboard.vue"

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Login
  },
  // {
  //   path: "/FetchData",
  //   name: "FetchData",
  //   component: FetchData,
  // },
{
    path: "/Login",
    name: "Login",
    component: Login,
},
{
    path: "/Register",
    name: "Register",
    component: Register
},
{
    path: "/Dashboard",
    name: "Dashboard",
    component: Dashboard,
    children: [
        {
            path: 'Desarrollo'
           
        }]
}];

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
