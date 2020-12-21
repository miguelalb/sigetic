<template>
  <div id="register">
    <NavMenu page="Login" />
    <div class="card">
      <form>
        <h2 class="form-title">REGISTER</h2>
        <div class="form-group">
          <input
            type="text"
            id="username"
            name="username"
            placeholder="&#61447;"
          />
        </div>
        <div class="form-group">
          <input
            type="text"
            id="email"
            name="email"
            placeholder="&#xf0e0;"
          />
        </div>
        <div class="form-group">
          <input
            type="text"
            id="password"
            name="username"
            placeholder="&#61475;"
          />
        </div>
        <button class="btn btn-light btn-register">SIGN UP</button>
      </form>
    </div>
  </div>
</template>

<script>
import NavMenu from "./NavMenu.vue";

export default {
  name: "Register",
  components: {
    NavMenu,
  },
};
</script>

<style scoped>
@import "//netdna.bootstrapcdn.com/font-awesome/3.0/css/font-awesome.css";
/* INPUTS */

form input {
  display: block;
  width: 100%;
  border-radius: 30px;
  margin: 10px 0;
  height: 3.54rem;
  background-color: rgba(196, 196, 196, 0.54);
  border: none;
  font-size: 2rem;
  font-weight: 100;
}
/* REMOVE OUTLINE */
form input:focus {
  outline: none;
  text-indent: 20px;
}
/* REMOVE PLACEHOLDER ON FOCUS */
form input:focus::placeholder{
  color: transparent;
}
/* FONT-AWESOME PLACEHOLDER */
form input::-webkit-input-placeholder {
  font-family: FontAwesome;
  font-weight: normal;
  overflow: visible;
  vertical-align: top;
  display: inline-block !important;
  padding-left: 20px;
  padding-top: 2px;
}

.form-group.remember-me {
  margin-bottom: 20px;
  text-align: left;
}

.btn-register {
  font-weight: 700;
  font-size: 2rem;
  width: 100%;
  height: 2em;
  margin-top: 3rem;
}
</style>