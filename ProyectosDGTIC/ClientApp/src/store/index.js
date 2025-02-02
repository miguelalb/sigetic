import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    userName: 'Miguel',
    menuItems: [{ class: "far fa-building", menu: "General" }, { class: "fab fa-uncharted", menu: "Desarrollo" }, { class: "fas fa-server", menu: "Infraestructura" },
    { class: "fas fa-shield-alt", menu: "Seguridad" }, { class: "far fa-file", menu: "Documentacion" }, { class: "fas fa-hands", menu: "ServiciosTI" },
    { class: "far fa-folder", menu: "ProyectosTI" }],
    resumen: {total: 50, cerrados: 20, vencidos: 2, abiertos: 25, atrasados: 10, aTiempo: 13},
    chartTypes: { type1: 'pie donut', type2: 'gauge' },
    dashboardTable: {
        headers: [
          {
            text: 'No.',
            align: 'start',
            sortable: 'true',
            value: 'id'
          },
          { text: 'Descripcion', value: 'descripcion'},
          { text: 'Proyecto', value: 'proyecto'},
          { text: 'Status', value: 'status'},
          { text: 'Asignado', value: 'asignado'},
          { text: 'Función', value: 'funcion'},
        ],
        items: [
          { 
            id: 1, descripcion: 'Migración del Código Fuente a C#',
            proyecto: 'Sistema de Gestión de Proyectos', status: 'Cerrado',
            asignado: 'Sebastian Jimenez', funcion: 'Programador'
          },
          { 
            id: 2, descripcion: 'Levantamiento de Requerimientos',
            proyecto: 'Sistema de turnos', status: 'Abierto',
            asignado: 'Miguel Acevedo', funcion: 'Programador'
          },
          { 
            id: 3, descripcion: 'Agregar Check List de Evaluación',
            proyecto: 'SIEP', status: 'Atrasado',
            asignado: 'Jonathan Medina', funcion: 'Programador'
          },
          { 
            id: 4, descripcion: 'Evaluar Desempeño en Desarrollo de App',
            proyecto: 'Asistencia VIAL', status: 'Abierto',
            asignado: 'Alexis Castro', funcion: 'Encargado'
          },
          { 
            id: 5, descripcion: 'Levantamiento de Requerimientos',
            proyecto: 'SICCON', status: 'Cerrado',
            asignado: 'Isaac De La Cruz', funcion: 'Programador'
          },
          { 
            id: 6, descripcion: 'Implementar Cambios Aprobados por Director',
            proyecto: 'Sistema de Viviendas', status: 'Cerrado',
            asignado: 'Cristian Pinales', funcion: 'Programador'
          },
        ] 

      }
  },
  mutations: {

  },
  actions: {

  },
  getters: {
    menuItems(state) {
      return state.menuItems;
    },
    resumen(state) {
      return state.resumen;
    },
    dashboardTable(state) {
      return state.dashboardTable;
    },
    chartOptions(state){
      const options = [
        {
          type: 'pyramid',
          palette: 'rainforest',
          title_label_text: 'Detalle Gráfico',
          series: [{
            points: [
              { x: 'Vencidos', y: state.resumen.vencidos },
              { x: 'Abiertos', y: state.resumen.abiertos },
              { x: 'Atrasados', y: state.resumen.atrasados },
              { x: 'A tiempo', y: state.resumen.aTiempo }
            ]
          }]
        }, 
        {
          type: 'pie donut',
          palette: 'fiveColor28',
          title_label_text: 'Abiertos vs Vencidos',
          series: [{
            points: [
              { x: 'Vencidos', y: state.resumen.vencidos },
              { x: 'Abiertos', y: state.resumen.abiertos }
            ]
          }]
        },
        {
          type: 'pie donut',
          palette: 'fiveColor21',
          title_label_text: 'Atrasados vs A Tiempo',
          series: [{
            points: [
              { x: 'Atrasados', y: state.resumen.atrasados },
              { x: 'A tiempo', y: state.resumen.aTiempo }
            ]
          }]
        },
      ];
      return options
    }
  }
})
