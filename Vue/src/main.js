import { createApp } from 'vue'
import App from './App.vue'
import MISAInput from '@/components/input/MISAInput.vue'
import MISAButton from '@/components/button/MISAButton.vue'
import vueRouter from './router/router'

const app = createApp(App);
app.component("m_input",MISAInput);
app.component("m_button",MISAButton);
app.use(vueRouter)
app.mount('#app');
