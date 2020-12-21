import { createWebHistory, createRouter } from "vue-router";
// import Home from "@/components/Home.vue";
import Counter from "@/components/Counter.vue";
import FetchData from "@/components/FetchData.vue";
import Login from "@/components/Login.vue";
import Register from "@/components/Register.vue";
import Dashboard from "@/components/Dashboard.vue";

const routes = [
    {
        path: "/",
        name: "Home",
        component: Login,
    },
    {
        path: "/Counter",
        name: "Counter",
        component: Counter,
    },
    {
        path: "/FetchData",
        name: "FetchData",
        component: FetchData,
    },
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
        beforeEnter(to, from, next) {
            let currentUser = JSON.parse(window.localStorage.currentUser);
            if(currentUser && currentUser.name) {
                next();
            } else {
                next("/");
            } 
        }
    }
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});



export default router;