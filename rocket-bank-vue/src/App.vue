<template>
  <router-view></router-view>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style lang="scss">
@import '../node_modules/materialize-css/sass/materialize.scss';
@import './assets/scss/rocket-design-system.scss';

 html, body {
   margin: 0;
   padding: 0;
   overflow: hidden;
 }

.rocket-red {
  @extend .red, .darken-2;
  background-color: $rocket-red !important;
}

.input-field input:focus + label {
     color: $rocket-red !important;
}

.input-field input:focus {
     border-bottom: 1px solid $rocket-red !important;
     box-shadow: 0 1px 0 0 $rocket-red !important;
   }
</style>
