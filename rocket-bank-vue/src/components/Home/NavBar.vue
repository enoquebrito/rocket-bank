<template>
  <!-- Dropdown Options -->
  <ul id="dropdown1" class="dropdown-content">
    <li>
      <span class="dropdown-option">
        <span class="material-icons">account_circle</span>
        <span>minha conta</span>
      </span>
    </li>
    <li>
      <span class="dropdown-option">
        <span class="material-icons">manage_accounts</span>
        <span>segurança</span>
      </span>
    </li>
    <li class="divider"></li>
    <li>
      <span class="dropdown-option">
        <span class="material-icons">logout</span>
        <span>sair</span>
      </span>
    </li>
  </ul>

  <!-- Nav Init -->
  <nav>
    <div class="nav-wrapper navbar-fixed">
      <div class="nav-container menu-icon">
        <MenuIcon />
      </div>
      <span class="nav-container title">
        Abertura de Conta
      </span>
      <ul class="right">
        <!-- Dropdown Trigger -->
        <li>
          <a class="nav-container dropdown-trigger" data-target="dropdown1">
            <span>Usuário Logado</span>
            <i class="material-icons right">arrow_drop_down</i>
          </a>
        </li>
      </ul>
    </div>
  </nav>
</template>

<script>
import M from 'materialize-css'

import MenuIcon from './MenuIcon'

export default {
  name: 'NavBar',
  components: {
    MenuIcon
  },
  mounted () {
    M.AutoInit()
  }
}
</script>

<style lang="scss" scoped>
@import '../../assets/scss/rocket-design-system.scss';

.brand-logo {
  margin-left: 20px;
}

.dropdown-option {
  color: #3D3456;
  display: flex;
  vertical-align: middle;
}

.material-icons {
  margin-right: 10px;
  height: 0;
  line-height: revert;
}

.nav-wrapper {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
  background-color: $rocket-blue;
  color: $rocket-white;
}

nav {
  height: 7vh;
  line-height: 7vh;
}

.menu-icon {
  margin-left: 10px;
}

.menu-icon:hover {
  cursor: pointer;
}

.title {
  font-size: 30px;
}
</style>
