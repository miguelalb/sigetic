<template>
  <div id="dashboard">
    <nav-menu-app></nav-menu-app>
    <div class="content">
      <side-menu></side-menu>
      <div class="main">
        <section class="main-top">
          <div class="card-report" id="total-card">
            <div class="card-top">
              <h3>TOTAL</h3>
              <h4>{{ $store.getters.resumen.cerrados }} <span class="light">CERRADOS</span></h4>
            </div>
            <div class="card-bottom">
              <h1>{{ $store.getters.resumen.total }}</h1>
            </div>
          </div>
          <div class="card-report" id="restantes-card">
            <div class="card-top">
              <h3>ABIERTOS</h3>
              <h4>{{ $store.getters.resumen.vencidos }} <span class="light">VENCIDOS</span></h4>
            </div>
            <div class="card-bottom">
              <h1>{{ $store.getters.resumen.abiertos }}</h1>
            </div>
          </div>
          <div class="card-report" id="p50-card">
            <div class="card-top">
              <h3>ATRASADOS</h3>              
            </div>
            <div class="card-bottom">
              <h1>{{ $store.getters.resumen.atrasados }}</h1>
            </div>
          </div>
          <div class="card-report" id="p75-card">
            <div class="card-top">
              <h3>A TIEMPO</h3>
            </div>
            <div class="card-bottom">
              <h1>{{ $store.getters.resumen.aTiempo }}</h1>
            </div>
          </div>
        </section>
        <section class="main-bottom">
          <div class="charts">
            <JSCharting :options="$store.getters.chartOptions[0]" class="columnChart"></JSCharting>
            <JSCharting :options="$store.getters.chartOptions[1]" class="columnChart"></JSCharting>
            <JSCharting :options="$store.getters.chartOptions[2]" class="columnChart"></JSCharting>
          </div>
          <h2>Detalle</h2>
          <div class="table">
            <v-data-table
            dense
            :headers="$store.getters.dashboardTable.headers"
            :items="$store.getters.dashboardTable.items"
            item-key="id"
            class="elevation-1"
            ></v-data-table>
          </div>
        </section>
      </div>
    </div>
  </div>
</template>

<script>
import NavMenuApp from "./NavMenuApp.vue";
import SideMenu from "./SideMenu.vue";
import JSCharting from 'jscharting-vue';

export default {
  name: "Dashboard",
  components: {
    NavMenuApp,
    SideMenu,
    JSCharting
  },
  data() {
    return {
      
    };
  },
};
</script>

<style scoped>
* {
  transition: all 0.3s ease-out;
}
.content {
  display: flex;
  height: 100vh;
  width: 100vw;
}
.main {
  display: flex;
  flex-direction: column;
  padding: 2rem 1rem;
  width: 85%;
}

.main-top {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-evenly;
}

.card-report {
  width: 15rem;
  height: 8rem;
  border-radius: 15px;
  background-color: #c4c4c4;
  margin-right: 1.5rem;
  padding: 1rem;
}

.card-report:hover {
  transform: scale(1.02);
}

.card-report .card-top {
  display: flex;
  align-items: center;
  justify-content: space-between;
  font-size: 14px;
}
.card-report .card-bottom {
  font-size: 22px;
  font-weight: 800;
}

#total-card {
  background: url("../assets/img/TotalCard.png") no-repeat center center/cover;
  color: #fff;
}

.card-top .light {
  font-weight: 300;
}

#restantes-card {
  background: url("../assets/img/RestantesCard.png") no-repeat center center/cover;
  color: #3598cf;
}
#restantes-card h4 { 
  color: var(--secondary-color); 
  }

#p50-card {
  background: url("../assets/img/Progreso50Card.png") no-repeat center
    center/cover;
  color: #ebbc17;
}
#p75-card {
  background: url("../assets/img/Progreso75Card.png") no-repeat center
    center/cover;
  color: #4cd693;
}

.main-bottom {
  width: 100%;
  height: 100%;
}
.main-bottom .table {
  width: 95%;
  height: 60%;
  /* background-color: #c4c4c4; */
}

.charts {
  width: 100%;
  height: 30%; 
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  padding: 1rem 0;
}
.columnChart {
    height: 100%;
    width: 24%;
}
</style>