<template>
  <NavBar />
  <div class="content-container">
    <SideBar :class="[{ 'transition' : !showSideBar }, 'content-side']">
      <ul>
        <router-link to="/home"><li class="sidenav-item">Novo Cadastro</li></router-link>
        <router-link to="/home/comprovante"><li class="sidenav-item">Comprovantes</li></router-link>
     </ul>
    </SideBar>
    <div :class="[(showSideBar ? 'content-show' : 'content-hide'), 'content-view']">
      <router-view></router-view>
    </div>
  </div>
</template>

<script>
import { mapState } from 'vuex'
import NavBar from '../components/Home/NavBar'
import SideBar from '../components/Home/SideBar.vue'

export default {
  name: 'Home',
  components: {
    NavBar,
    SideBar
  },
  computed: {
    ...mapState(['showSideBar'])
  }
}
</script>

<style lang="scss" scoped>
@import '../assets/scss/rocket-design-system.scss';

.rocket-side {
  padding: 0;
}

.sidenav-item {
  padding: 10px 10px 10px 30px;
  text-transform: lowercase;
  margin-bottom: 8px;
  font-size: 23px;
}

li:hover {
  background-color: $rocket-red;
  color: $rocket-white;
}

li {
  color: $rocket-blue;
}

.content-container {
  display: flex;
}

.content-view {
  flex-grow: 1;
  transition: all 600ms linear;
}

.content-side {
  flex-grow: 0.001
}

.content-hide {
  width: 100vh;
}

.transition {
  flex-grow: 0.000001;
}
</style>
