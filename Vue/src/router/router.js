import {createRouter, createWebHistory} from 'vue-router'
import EmployeeList from "@/view/EmployeeList"
import CustomerList from "@/view/customer/CustomerList.vue"
import ReportList from "@/view/report/ReportList.vue"
import Settings from "@/view/settingsPages/Settings.vue"

// dinh nghia router:
const routers = [
    { path:"/employee", component: EmployeeList, name:"EmployeeRouter", },
    { path:"/customer", component: CustomerList, name:"EmployeeRouter", },
    { path:"/report", component: ReportList, name:"ReportListRouter", },
    { path:"/settings", component: Settings, name:"SettingsRouter", },
    
]

//khoi tao vue router:
const vueRouter = createRouter({
    mode: createWebHistory(),
    history:createWebHistory(),
    routes: routers,
})

//export:
export default vueRouter;