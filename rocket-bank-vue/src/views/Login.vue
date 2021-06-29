<template>
<section class="row red lighten-5">
   <!-- Right Side -->
   <div class="col l6 hide-on-med-and-down">
      <img src="../assets/animated-login.gif" alt="">
   </div>
   <!-- Left Side -->
   <div class="col s12 l6">
      <div class="container">
         <div class="row login-area center-align">
            <div class="titulo-sistema col s12">
               <p class="rocket">ROCKET</p>
               <p class="bank">bank</p>
            </div>
            <div class="input-field col s12">
               <input id="usuario" type="text" class="validate">
               <label for="usuario">Usuário</label>
            </div>
            <div class="input-field col s12">
               <input id="password" type="password" class="validate">
               <label for="password">Senha</label>
            </div>
            <div class="input-field col s12">
               <a class="waves-effect waves-light rocket-red btn">Entrar</a>
            </div>
         </div>
      </div>
   </div>
</section>
</template>

<script>
export default {
  name: 'Login'
}
</script>

<style scoped>
  @font-face {
    font-family: Womby;
    src: url('../assets/Womby.ttf')
  }

  section {
    height: 100vh;
    overflow: hidden;
  }

  img {
    width:100%;
    height:99vh;
    object-fit: cover;
    overflow: hidden;
  }

  .rocket {
  font-size: 80px;
  font-family: "Womby";
  color: rgb( 221, 54, 87 );
  opacity: 0.988;
  }

  .bank {
  font-size: 58px;
  font-family: "Segoe Script";
  color: rgb( 61, 52, 86 );
  margin-top: -45px;
  transform: translateX(40px);
}

  .btn {
    width: 100%;
    margin-top: 5%;
  }

  .container {
    min-width: 480px;
    overflow: hidden;
  }

  .login-area {
    margin-top: 25vh;
    min-width: 480px;
  }

  p {
    margin: 0;
  }
</style>
