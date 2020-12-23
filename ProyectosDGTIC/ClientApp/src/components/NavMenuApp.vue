<template>
  <header>
    <nav class="navbar">
      <div class="container">
        <div class="nav-item nav-left">
          <img src="../assets/img/logomopc.png" alt="MOPC Logo" class="logo" />
          <h2>SIGETIC</h2>
        </div>
        <div class="nav-item nav-right">
             <h3>Bienvenido <span id="user">{{ userName }}</span></h3>
             <img src="../assets/img/UserIcon.png" alt="User Logo" id="user-icon">
             <a href="#"><i class="fas fa-sign-out-alt"></i></a>
        </div>
      </div>
    </nav>
  </header>
</template>
<script>
// import EventBus from '../main.js';

export default {
  name: "NavMenuApp",
  data() {
    return {
      isExpanded: false
    };
  }, 
  props: {
      userName: String,
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

<style scoped>
@import url('https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css');

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
.nav-item.nav-left,
.nav-item.nav-right {
  display: flex;
  flex-direction: row;
  align-items: center;
}
.nav-item.nav-right > * {
    padding: 0 0.2rem;
}
.nav-item.nav-right > img {
    width: 1.5rem;
}
.nav-item.nav-right a {
  margin-left: 1.3rem;
  font-size: 1.4rem;
}
img.logo {
  width: 5rem;
}
.nav-item.nav-left h2 {
  padding: 2px;
  margin-left: 2px;
}
.nav-item.nav-item.nav-right h3 {
    font-weight: 300;
}
#user {
    font-weight: 600;
}
</style>
