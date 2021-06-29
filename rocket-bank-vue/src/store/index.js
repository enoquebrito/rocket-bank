import { createStore } from 'vuex'

export default createStore({
  state: {
    showSideBar: true
  },
  mutations: {
    toggleSideBar: (state) => {
      state.showSideBar = !state.showSideBar
    }
  }
})
