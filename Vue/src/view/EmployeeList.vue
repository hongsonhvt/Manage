<template>
<div class="container__first">
                  <div class="container__first-header">
                      <h1 class="container__first-title">Nhân Viên</h1>
                      <button class="Primary_Btn" id="btn-add" @click ="ShowFormDetail">Thêm mới nhân viên</button>
                  </div>
                  <div class="container__second">
                      <div class="table_user">
                          <div class="container_search-bar">
                              <div class="wrap">
                                  <div class="search">
                                     <input type="text" class="searchTerm pad-l10" placeholder="Tìm kiếm theo mã, tên nhân viên">
                                     <button type="submit" class="searchButton">
                                       <i class="container_search"></i>
                                    </button>
                                    <i class="container_ref"></i>
                                  </div>
                               </div>
                          </div>
                          <div class="table_user-table" id="tbEmployee">
                              <table class="container__table-user">
                                  <thead>
                                      <tr class="containrt__table-detail">
                                          <th  class="cont-table-1">
                                              <input type="checkbox" checked="checked">
                                              <span class="checkmark"></span>
                                          </th>
                                          <th class="cont-table-2" model-name="EmployeeCode"><p class="pad-l-5" >Mã Nhân Viên</p></th>
                                          <th class="cont-table-3" model-name="FullName"><p class="pad-l-5">Tên Nhân Viên</p></th>
                                          <th class="cont-table-4" model-name="GenderName"> <p class="pad-l-5" >Giới Tính</p></th>
                                          <th class="cont-table-5" model-name="DateOfBirth"><p class="pad-l-5" >Ngày Sinh</p></th>
                                          <th class="cont-table-6" model-name="EmployeeId"><p class="pad-l-5" >Số CMND</p></th>
                                          <th class="cont-table-7" model-name=""><p class="pad-l-5" >Chức Danh</p></th>
                                          <th class="cont-table-8" model-name="DepartmentName"><p class="pad-l-5" >Tên Đơn Vị</p></th>
                                          <th class="cont-table-9" model-name=""><p class="pad-l-5" >Số Tài Khoản</p></th>
                                          <th class="cont-table-10" model-name=""><p class="pad-l-5">Tên Ngân Hàng</p></th>
                                          <th class="cont-table-11" model-name=""><p class="pad-l-5">Chi Nhánh TK Ngân Hàng</p></th>
                                          <th class="cont-table-12" model-name=""><p class="pad-l-5">Chức Năng</p></th>
                                      </tr>
                                  </thead>
                                  <tbody>
                                      
                                  <tr class="containrt__table-detail-1" v-for="item in employees" :key="item.EmployeeId" @dblclick="rowOnDbClick(item)">
                                      <td class="table-1">
                                          <input type="checkbox" checked="checked">
                                          <span class="checkmark"></span>
                                      </td>
                                      <td class="table-2"><p class="pad-l-5">{{ item.EmployeeCode }}</p></td>
                                      <td class="table-3"><P class="pad-l-5">{{ item.FullName }}</P></td>
                                      <td class="table-4"><p class="pad-l-5">{{ item.GenderName }}</p></td>
                                      <td class="table-5"><p class="pad-l-5">{{ item.DateOfBirth }}</p></td>
                                      <td class="table-6"><p class="pad-l-5">{{ item.IdentityNumber }}</p></td>
                                      <td class="table-7"><p class="pad-l-5">{{ item.PositionName }}</p></td>
                                      <td class="table-8"><p class="pad-l-5">{{ item.DepartmentName }}</p></td>
                                      <td class="table-9"><p class="pad-l-5">{{ item.NationalityId }}</p></td>
                                      <td class="table-10"><p class="pad-l-5"></p></td>
                                      <td class="table-11"><p class="pad-l-5"></p></td>
                                      <td class="table-12">
                                          
                                            <div class="dropdown_option">
                                                <span class=" flo-lft pad-l10 Sua_css">
                                                Sửa
                                                </span>
                                                <div class="dropdown-content-choice" >
                                                    <i class=" sprite_dropdown flo-lft" id="menu"></i>
                                                    <div class="dropdown-content-option">
                                                    <a href="#">Nhân Bản</a>
                                                    <a href="#">Xóa</a>
                                                    <a href="#">Ngừng Sử Dụng</a>
                                                    </div>
                                            </div>
                                                
                                          
                                          </div>
                                          
                                          
                                      </td>
                                  </tr>

                                  </tbody>
                              </table>
                              
                          </div>
                          
                      </div>
                      <div class="container-footer">
                          <div class="number_pages">
                              <p class="container-footer-pages mar-t20">Tổng Số:</p>
                              <p class="pages_number mar-t20">1035</p>
                              <p class="page-number-1 mar-t20">bản ghi</p>
                          </div>
                          <div class="container__footer-right">
                              <div class="dropdown">
                                  <button class="dropbtn">20 bản ghi trên 1 trang <i class="Drop_Down"></i></button>
                                  <div class="dropdown-content">
                                  <a href="#" class="dropbtn-item-1">10 bản ghi trên 1 trang</a>
                                  <a href="#" class="dropbtn-item-1">20 bản ghi trên 1 trang</a>
                                  <a href="#" class="dropbtn-item-1">30 bản ghi trên 1 trang</a>
                                  <a href="#" class="dropbtn-item-1">50 bản ghi trên 1 trang</a>
                                  <a href="#" class="dropbtn-item-1">100 bản ghi trên 1 trang</a>
                                  </div>
                              </div>
                              <div class="number_of_pages">
                                  <ul class="pagination home-product__pagination">
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">Trước</a>
                                      </li>
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">1</a>
                                      </li>
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">2</a>
                                      </li>
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">3</a>
                                      </li>
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">...</a>
                                      </li>
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">52</a>
                                      </li>
                                      <li class="pagination-item">
                                          <a href="" class="pagination-item__link">Sau</a>
                                      </li>
                                  </ul>
                              </div>
                          </div>
                          </div>
                  </div>

              </div>
              <EmployeeAdd ref="EmpShow"  :employeeInput="employeeSelected"></EmployeeAdd>
</template>
<script>
import EmployeeAdd from '@/view/EmployeeAdd';
  export default {
    name:"EmployeeList",
    components: {
        EmployeeAdd
    },
    props:[
        "employeeInput"
    ],
    created() {
    fetch("https://cukcuk.manhnv.net/api/v1/Employees")
      .then((res) => res.json())
      .then((data) => {
        this.employees = data;
      });
    },
    methods: {
        ShowFormDetail(){
            this.isShow = true;
            this.$refs.EmpShow.ShowFormEmployee();
        },
        rowOnDbClick(employee) {
        this.employeeSelected = employee;
        this.isShowDetail = true;
        this.$refs.EmpShow.ShowFormEmployee();
        },
        
    },
    
    data(){
        return {
            isShow : false,
            employees: [],
            employeeSelected: {},
            isShowDetail: false,
        }
    }

  }
 
</script>
<style scoped>
  @import url(@/style/main.css);
</style>