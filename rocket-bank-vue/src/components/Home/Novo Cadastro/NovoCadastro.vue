<template>
  <div>
    <div class="container">
      <h4>Novo Cadastro</h4>
      <div class="row">
        <div class="input-field col s12 l12">
          <input id="nome-completo" type="text" class="validate" v-model="nomeCompleto">
          <label for="nome-completo">Nome Completo</label>
        </div>
      </div>
      <div class="row">
        <div class="input-field col s12 l6">
          <input id="email" type="text" class="validate" v-model="email">
          <label for="email">Email</label>
        </div>
        <div class="input-field col s12 l6">
          <input id="phone" type="tel" class="validate" v-model="telefone" v-mask="'## #####-####'">
          <label for="phone">Telefone</label>
        </div>
      </div>
      <div class="row">
        <div class="input-field col s12 l6">
          <input id="cpf" type="email" class="validate" v-model="cpf" v-mask="'###.###.###-##'">
          <label for="cpf">CPF</label>
        </div>
        <div class="input-field col s12 l6">
          <input id="data-nascimento" type="text" class="validate" max="2003-05-31" onfocus="(this.type='date')" onblur="if(!this.value)this.type='text'" v-model="dataNascimento">
          <label for="data-nascimento">Data de Nascimento</label>
        </div>
      </div>
      <div class="row">
        <div class="input-field col s12 l12">
          <input id="nome-mãe" type="text" class="validate">
          <label for="nome-mãe">Nome da Mãe</label>
        </div>
      </div>
      <div class="row">
        <div class="input-field col s12 l12">
          <button class="waves-effect waves-light rocket-red btn" @click="submit">Enviar</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mask } from 'vue-the-mask'
import M from 'materialize-css'

export default {
  data: () => {
    return {
      nomeCompleto: '',
      email: '',
      telefone: '',
      dataNascimento: '',
      cpf: '',
      nomeMae: ''
    }
  },
  methods: {
    submit: () => {
      M.toast({
        html: 'Ainda não implementado'
      })
      console.log('Click')
    }
  },
  directives: {
    mask
  }
}
</script>

<style lang="scss" scoped>
.btn {
  float: right;
  padding: 0 40px;
}

::-webkit-datetime-edit-year-field:not([aria-valuenow]),
::-webkit-datetime-edit-month-field:not([aria-valuenow]),
::-webkit-datetime-edit-day-field:not([aria-valuenow]) {
    color: transparent;
}
</style>
