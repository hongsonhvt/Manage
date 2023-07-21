<template>
  <div class="grid">
    <!-- Nav Bar -->
    <TheNavBar></TheNavBar>
    <div class="app">
        <TheHeader></TheHeader>
        <TheContainer></TheContainer>
        <TheFooter></TheFooter>
    </div>
  </div>
</template>

<script>
import TheHeader from '../src/layout/TheHeader.vue'
import TheNavBar from '../src/layout/TheNavBar.vue'
import TheContainer from '../src/layout/TheContainer.vue'
import TheFooter from '../src/layout/TheFooter.vue'
export default {
  name: 'App',
  components: {
    TheHeader, TheContainer, TheFooter,  TheNavBar
  }
}

</script>


<style>

</style>
