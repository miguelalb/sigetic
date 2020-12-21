<template>
  <header>
    <nav class="navbar">
      <div class="container">
        <div class="nav-item nav-left">
          <img src="../assets/img/logomopc.png" alt="MOPC Logo" class="logo" />
          <h2>SIGETIC</h2>
        </div>
        <span v-if="isLoggedIn"><p>Hello</p></span>
        <span v-else>
        <div class="nav-item nav-right">
             <router-link :to="page">{{ page }}</router-link>
        </div></span>
      </div>
    </nav>
  </header>
</template>
<script>
// import EventBus from '../main.js';

export default {
  name: "NavMenu",
  props: {
      page: String,
  },
  data() {
    return {
      isExpanded: false,
      isLoggedIn: false,
    };
  },
  methods: {
    collapse() {
      this.isExpanded = false;
    },

    toggle() {
      this.isExpanded = !this.isExpanded;
    },
  },
};
</script>

<style>
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
