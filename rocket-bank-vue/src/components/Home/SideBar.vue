<template>
  <div class="sidebar">
    <transition name="slide">
      <div v-if="showSideBar" class="sidebar-panel">
        <slot></slot>
      </div>
    </transition>
  </div>

</template>

<script>
import { mapState, mapMutations } from 'vuex'

export default {
  computed: {
    ...mapState(['showSideBar'])
  },
  methods: {
    ...mapMutations({
      toggle: 'toggleSideBar'
    })
  }
}
</script>

<style lang="scss" scoped>
@import '../../assets/scss/rocket-design-system.scss';

.slide-enter-active,
.slide-leave-active {
  transition: transform 0.4s ease;
}

.slide-enter-from,
.slide-leave-to {
  transform: translateX(-100%);
  transition: all 400ms ease-in 0s;
}

.sidebar-panel {
  box-shadow: 2px 2px 10px $rocket-blue;
  background-color: $rocket-white;
  overflow-y: auto;
  height: 93vh;
  width: 300px;
}
</style>
