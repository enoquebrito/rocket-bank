import { createRouter, createWebHistory } from 'vue-router'

import Home from '../views/Home.vue'
import Login from '../views/Login.vue'
import Comprovantes from '../components/Home/Comprovantes/Comprovantes.vue'
import NovoCadastro from '../components/Home/Novo Cadastro/NovoCadastro.vue'

const routes = [
  {
    path: '/home',
    name: 'Home',
    component: Home,
    children: [
      {
        path: '',
        name: 'Cadastro',
        component: NovoCadastro
      },
      {
        path: '/home/comprovante',
        name: 'Comprovante',
        component: Comprovantes
      }
    ]
  },
  {
    path: '/login',
    name: 'Login',
    component: Login
  }
  // {
  //   path: '/about',
  //   name: 'About',
  //   // route level code-splitting
  //   // this generates a separate chunk (about.[hash].js) for this route
  //   // which is lazy-loaded when the route is visited.
  //   component: () => import(/* webpackChunkName: "about" */ '../views/About.vue')
  // }
]

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
