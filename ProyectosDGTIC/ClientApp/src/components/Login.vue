<template>
  <div id="login">
    <NavMenu page="Register" />
    <div class="card">
      <form @submit.prevent="login"> 
        <h2 class="form-title">USER LOGIN</h2>
        <div class="form-group">
          <input
            type= "text"
            id= "username"
            name= "username"
            v-model= "input.username"
            placeholder= "&#61447;"
          />
        </div>
        <div class="form-group">
          <input
            type="password"
            id="password"
            name="username"
            v-model= "input.password"
            placeholder="&#61475;"
          />
        </div>
        <div class="form-group remember-me">
          <input type="checkbox" name="rememberme" id="remember-me" />
          <span>Remember Me</span>
        </div>
        <button class="btn btn-light btn-login" type="submit">LOGIN</button>
      </form>
    </div>
  </div>
</template>

<script>
import NavMenu from "./NavMenu.vue";
import axios from 'axios';

export default {
  name: "Login",
  components: {
    NavMenu,
  },
  data() {
    return {
      input: {
        username: '',
        password: '',
      },
      response: null
    }
  },
  methods: {
    login() {
      if (this.input.username != "" && this.input.password != "") {
        axios.post('/api/Account/Login', this.input)
          .then((response) => {
            this.response = response.data;
            console.log(this.response);
            this.input.username = '';
            this.input.password = '';
          })
          .catch(function (err) {
            console.log(err);
          })
      }
    }
  }
};
</script>

<style scoped>
@import "//netdna.bootstrapcdn.com/font-awesome/3.0/css/font-awesome.css";

/* INPUTS */
form input#username,
form input#password {
  display: block;
  width: 100%;
  border-radius: 30px;
  margin: 20px 0;
  height: 4rem;
  background-color: rgba(196, 196, 196, 0.54);
  border: none;
  font-size: 2rem;
  font-weight: 100;
}
/* REMOVE OUTLINE */
form input#username:focus,
form input#password:focus {
  outline: none;
  text-indent: 20px;
}
/* REMOVE PLACEHOLDER ON FOCUS */
form input#username:focus::placeholder,
form input#password:focus::placeholder {
  color: transparent;
}
/* FONT-AWESOME PLACEHOLDER */
form input#username::-webkit-input-placeholder,
form input#password::-webkit-input-placeholder {
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
input#remember-me {
  margin: 0 1rem;
  border: 1px solid rgba(196, 196, 196, 0.54);
  width: 1rem;
}
input[type=checkbox] {
    transform: scale(1.5);
}
.btn-login {
  font-weight: 700;
  font-size: 2rem;
  width: 100%;
  height: 2em;
  margin-top: 1.5rem;
}
</style>