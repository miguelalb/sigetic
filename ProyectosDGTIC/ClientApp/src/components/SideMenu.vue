<template>
  <div class="sidenav">
          <div class="sidenav-top-content" >
            <span v-for="(item, index) in $store.getters.menuItems" :key="index">
              <a href="#" :class="{ active: selected == index }" @click="selected = index"><i :class="item.class"></i> {{ item.menu }}</a>
            </span>
          </div>
          <div class="sidenav-bottom-content">
            <img src="../assets/img/CupulaSidebar.png" alt="Cupula">
          </div>
        </div>
</template>

<script>
export default {
    name: 'SideMenu',
    data() {
    return {
      isActive: false,
      selected: 0,
    };
    },
    methods: {
      // selected: function() {
      //   this.isActive = !this.isActive;
      //   console.log("clicked");
      // }
    }
}
</script>

<style scoped>
@import url('https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css');
* {
  transition: all 0.3s ease-in-out;
}
.sidenav {
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  align-items: center;
  width: 15%;
  background-color: rgba(255, 255, 255, 0.25);
  padding-top: 2rem;
  height: 100%;
  overflow-x: hidden;
}
.sidenav a {
  text-decoration: none;
    color: #333;
}
.sidenav-top-content {
  display: flex;
  flex-direction: column;
  align-items: left;
  text-align: left;
}
.sidenav-top-content > * {
    
    margin: 5px 0;
    padding: 2px;
    font-size: 1.2rem;
}
.sidenav-top-content span > *:hover,
.active {
    border-bottom: 2px solid var(--secondary-color);
}
.sidenav-top-content span > *:hover i,
.active i {
    color: var(--secondary-color);
}
.sidenav-bottom-content img {
  width: 12rem;
  margin-bottom: 4rem;
}
</style>