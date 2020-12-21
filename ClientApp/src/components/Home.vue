<template>
  <div class="dashboard">
    <header>
      <nav class="navbar">
        <div class="container">
          <div class="nav-item nav-left">
            <img
              src="../assets/img/logomopc.png"
              alt="MOPC Logo"
              class="logo"
            />
            <h2>SIGETIC</h2>
          </div>

          <div class="nav-item nav-right">
            <router-link :to="page">{{ page }}</router-link>
          </div>
        </div>
      </nav>
    </header>
  </div>
</template>

<script>
// import NavMenu from "./NavMenu.vue";

export default {
  name: "Dashboard",
  components: {},
  props: {},
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.navbar {
  color: #fff;
  background: var(--primary-color);
  padding: 2px;
  height: 50px;
}
.navbar h2 {
  font-weight: 500;
}
.navbar a {
  text-decoration: none;
  color: #fff;
}
.navbar .container {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
  height: 100%;
}
.nav-item.nav-left {
  display: flex;
  flex-direction: row;
  align-items: center;
}
img.logo {
  width: 5rem;
}
.nav-item.nav-left h2 {
  padding: 2px;
  margin-left: 2px;
}
</style>
