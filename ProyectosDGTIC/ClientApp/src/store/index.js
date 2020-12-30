import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    userName: 'Miguel',
    menuItems: [{ class: "far fa-building", menu: "General" }, { class: "fab fa-uncharted", menu: "Desarrollo" }, { class: "fas fa-server", menu: "Infraestructura" },
    { class: "fas fa-shield-alt", menu: "Seguridad" }, { class: "far fa-file", menu: "Documentacion" }, { class: "fas fa-hands", menu: "ServiciosTI" },
    { class: "far fa-folder", menu: "ProyectosTI" }]
  },
  mutations: {

  },
  actions: {

  },
  getters: {
    menuItems(state) {
      return state.menuItems;
    }
  }
})
