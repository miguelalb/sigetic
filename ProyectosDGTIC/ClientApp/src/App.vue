<template>
  <div id="app">
    <router-view/>
  </div>
</template>
<script>
export default {
  name: 'App'
}
</script>

<style>

/* GENERIC STYLES */
@import url('https://fonts.googleapis.com/css2?family=Montserrat:wght@100;400;500;600;700;800&display=swap');
:root {
  --primary-color: #05549B;
  --secondary-color: #EC2329;
}

* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  font-family: 'Monserrat', sans-serif;
  line-height: 1.6;
  background-image: url('./assets/img/dgtic-bg.png');
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-position: bottom;
  background-size: cover;
}

.container {
  margin: 0 20px;
}



/* BUTTONS */
.btn {
  cursor: pointer;
  display: inline-block;
  padding: 10px 30px;
  border-radius: 30px;
  color: #fff;
  border: none;
  background: var(--primary-color);
} 
.btn:focus { outline:0; }

.btn-light {
  color: var(--primary-color);
  background: #fff;
  border: 2px solid var(--primary-color);
}
.btn-light:hover {
  color: #fff;
  border: none;
  background: var(--primary-color);
}

/* FORM ELEMENTS */
form {
  /* width: 100%; */
  height: 100%;
  width: 22rem;
  margin: 0 auto;
}
.form-group {
  width: 100%;
}

/* CARDS */
.card {
    background-color: #fff;
    height: 34rem;
    max-width: 35rem;
    margin: 4rem auto;
    border-radius: 25px;
    padding: 2rem;
    box-shadow: 0 10px 30px rgba(0, 0, 0, 0.5);
}

/* CARD-FORM */
.card form {
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
  letter-spacing: 1px;
}
.card form h2 {
  font-weight: 700;
  margin-bottom: 1rem;
  margin-top: 1rem;
  font-size: 1.9rem;
  font-family: "Montserrat", sans-serif;
}
</style>
