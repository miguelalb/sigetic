// import 'bootstrap/dist/css/bootstrap.css'
import { createApp, Vue } from 'vue'
import App from './App.vue'
import router from './router'

createApp(App).use(router).mount('#app')

const EventBus = new Vue();

export default EventBus;