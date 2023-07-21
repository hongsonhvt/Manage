<template>
    <div class="container">
        <EmployeeList></EmployeeList>
    </div>
  </template>
  <script>
  import EmployeeList from '../view/EmployeeList.vue'

  
  
  export default {
    name: "TheContainer",
    components: {
      EmployeeList
    }
  }
  </script>
  <style>
      @import url(@/style/main.css);
  </style>