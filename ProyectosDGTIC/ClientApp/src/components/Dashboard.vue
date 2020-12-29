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
              <h4>{{ completados }} <span class="light">COMPLETADOS</span></h4>
            </div>
            <div class="card-bottom">
              <h1>{{ total }}</h1>
            </div>
          </div>
          <div class="card-report" id="restantes-card">
            <div class="card-top">
              <h3>RESTANTES</h3>
              <h4>{{ todo }} <span class="light">TODO</span></h4>
            </div>
            <div class="card-bottom">
              <h1>{{ restantes }}</h1>
            </div>
          </div>
          <div class="card-report" id="p50-card">
            <div class="card-top">
              <h3>PROGRESO 50%</h3>              
            </div>
            <div class="card-bottom">
              <h1>{{ p50 }}</h1>
            </div>
          </div>
          <div class="card-report" id="p75-card">
            <div class="card-top">
              <h3>PROGRESO 75%</h3>
            </div>
            <div class="card-bottom">
              <h1>{{ p75 }}</h1>
            </div>
          </div>
        </section>
        <section class="main-bottom">
          <h2>Detalle</h2>
          <div class="table"></div>
        </section>
      </div>
    </div>
  </div>
</template>

<script>
import NavMenuApp from "./NavMenuApp.vue";
import SideMenu from "./SideMenu.vue";

export default {
  name: "Dashboard",
  components: {
    NavMenuApp,
    SideMenu,
  },
  data() {
    return {
      total: 45,
      completados: 20,
      restantes: 25,
      todo: 2,
      p50: 10,
      p75: 13,
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
}
.main {
  display: flex;
  flex-direction: column;
  padding: 2rem 1rem;
}

.main-top {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-evenly;
}

.card-report {
  width: 18rem;
  height: 11rem;
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
  font-size: 17px;
}
.card-report .card-bottom {
  font-size: 36px;
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
  height: 50%;
  background-color: #c4c4c4;
}
</style>