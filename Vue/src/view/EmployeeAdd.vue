<template>
    <div class="modal" id="new_emp" v-show="isShow">
            <div class="modal__overlay"  >
                <div class="modal__body" >
                    <div class="modal__inner">
                        <Form @submit="onSubmit" :validation-schema="schema">
                            <div class="modal__inner-header">
                            <span class="Modal__inner-inf flo-lft pad-r15">Thông tin khách hàng</span>
                            <input class="form__input-checkbox mar-r8 flo-lft" type="checkbox">
                            <span class="Modal__inner-inf_check flo-lft pad-r15">Là khách hàng</span>
                            <input class="form__input-checkbox mar-r8 flo-lft" type="checkbox">
                            <span class="Modal__inner-inf_check flo-lft">Là nhà cung cấp</span>
                            <i class="sprite_X" id="btn-close" @click ="CloseFormDetail"></i>
                            <i class="sprite_question"></i>
                        </div>
                        <div class="modal__inner-body">
                            <ul class="modal__inner-ul">
                                <li class="modal__inner-li-1">
                                    <div class="modal__inner-body-code modal__inner-span flo-lft pad-r15">
                                        <p class="modal__inner-title">Mã
                                            <span>*</span>
                                        </p>
                                        <!-- <input type="text" class="modal__inner-title-input pad-l10" v-model="employee.EmployeeCode" > -->
                                        <Field name="code"  class="modal__inner-title-input pad-l10" v-model="employee.EmployeeCode" placeholder="NV-0001"/>
                                        <ErrorMessage name="code" />
                                    </div>
                                    <div class="modal__inner-body-name modal__inner-span flo-lft pad-r25">
                                        <p class="modal__inner-title">Tên
                                            <span>*</span>
                                        </p>
                                        <!-- <input class="modal__inner-title-name pad-l10" type="text" v-model="employee.FullName"> -->
                                        <Field name="fullname"  class="modal__inner-title-input pad-l10" v-model="employee.FullName" placeholder="Nguyen Van A"/>
                                        <ErrorMessage name="fullname" />
                                    </div>  
                                    <div class="modal__inner-body-dob flo-lft pad-r15">
                                        <p class="modal__inner-title">Ngày Sinh</p>
                                        <input class="modal__inner-title-dob pad-l10" type="date">
                                    </div>
                                    <div class="modal__inner-body-gender flo-lft pad-r10">
                                        <p class="modal__inner-title pad-l10"> Giới Tính</p>
                                        <label class="modal__body-check-radio">
                                            <input type="radio" checked="checked" name="radio">
                                            <span class="checkmark_radio"></span>
                                            Nam
                                        </label>
                                        <label class="modal__body-check-radio">
                                            <input type="radio" checked="checked" name="radio">
                                            <span class="checkmark_radio"></span>
                                            Nữ
                                        </label>
                                        <label class="modal__body-check-radio">
                                            <input type="radio" checked="checked" name="radio">
                                            <span class="checkmark_radio"></span>
                                            Khác
                                        </label>
                                    </div>
                                </li>
                                <li class="modal__inner-li-1">
                                    <div class="modal__inner-body-donvi flo-lft pad-r25">
                                        <p class="modal__inner-title">Đơn Vị</p>
                                        <!-- <button>Phòng Nhân Sự <i class=" modal__inner-body-donvi-dropdown "></i></button> -->
                                        <div class="modal_inner-donvi-dropdown">
                                            <div class="modal_inner-donvi-select">
                                                <span class="modal_inner-donvi-selected">Phòng Nhân Sự </span>
                                                
                                            </div>
                                            <ul class="modal_inner-donvi-menu">
                                                <li>Framer</li>
                                                <li>Sketch</li>
                                                <li>Invision Studio</li>
                                                <li class="active">Figma</li>
                                                <li>Adobe XD</li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="modal__inner-body-cmnd flo-lft pad-r15 modal__inner-span">
                                        <p class="modal__inner-title">Số CMND</p>
                                        <!-- <input type="text" class="modal__inner-input-cmnd pad-l10" placeholder="6011735846"> -->
                                        <Field name="cmnd"  type="text" class="modal__inner-input-cmnd pad-l10" placeholder="6011735846"/>
                                        <ErrorMessage name="cmnd" />
                                    </div>
                                    <div class="modal__inner-body-dcmnd flo-lft pad-r15 ">
                                        <p class="modal__inner-title">Ngày Cấp</p>
                                        <input class="modal__inner-title-dcmnd pad-l10" type="date">
                                    </div>
                                </li>
                                <li class="modal__inner-li-1 ">
                                    <div class="modal__inner-body-CD flo-lft pad-r25 modal__inner-span">
                                        <p class="modal__inner-title">Chức Danh</p>
                                        <!-- <input class="modal__inner-title-CD pad-l10" type="text" placeholder="Lễ Tân Chính"> -->
                                        <Field name="title"  class="modal__inner-title-CD pad-l10" type="text" placeholder="Lễ Tân Chính"/>
                                        <ErrorMessage name="title" />
                                    </div>
                                    <div class="modal__inner-body-CD flo-lft modal__inner-span">
                                        <p class="modal__inner-title">Nơi Cấp</p>
                                        <!-- <input class="modal__inner-title-state pad-l10" type="text" placeholder="Hải Phòng"> -->
                                        <Field name="state"  class="modal__inner-title-state pad-l10" type="text" placeholder="Hải Phòng"/>
                                        <ErrorMessage name="state" />
                                    </div>
                                </li>
                                <li class="modal__inner-li-1">
                                    <div class="modal__inner-body-adress flo-lft pad-r25 modal__inner-span">
                                        <p class="modal__inner-title">Địa chỉ</p>
                                        <!-- <input class="modal__inner-title-adress pad-l10" type="text"  v-model="employee.Address"> -->
                                        <Field name="address"  class="modal__inner-title-adress pad-l10" type="text"  v-model="employee.Address" placeholder="2526 West Pine Tree Highway, Diamond Building, Salt Lake City, Utah "/>
                                        <ErrorMessage name="address" />
                                    </div>
                                </li>
                                <li class="modal__inner-li-1">
                                    <div class="modal__inner-body-phone-1 flo-lft pad-r25 modal__inner-span">
                                        <p class="modal__inner-title">ĐT di động</p>
                                        <!-- <input class="modal__inner-title-phone-1 pad-l10" type="text" v-model="employee.PhoneNumber"> -->
                                        <Field name="phone"  class="modal__inner-title-phone-1 pad-l10" type="text" v-model="employee.PhoneNumber"/>
                                        <ErrorMessage name="phone" />
                                    </div>
                                    <div class="modal__inner-body-phone-2 flo-lft pad-r25 modal__inner-span">
                                        <p class="modal__inner-title">ĐT cố định</p>
                                        <!-- <input class="modal__inner-title-phone-2 pad-l10" type="text" placeholder="(764)749-6478"> -->
                                        <Field name="phone"  class="modal__inner-title-phone-2 pad-l10" type="text" placeholder="(764)749-6478"/>
                                        <ErrorMessage name="phone" />
                                    </div>
                                    <div class="modal__inner-body-phone-email flo-lft pad-r25 modal__inner-span">
                                        <p class="modal__inner-title">Email</p>
                                        <!-- <input class="modal__inner-title-email pad-l10" type="email" placeholder="email@example.com" v-model="employee.Email"> -->
                                        <Field name="email"  class="modal__inner-title-email pad-l10" type="email" placeholder="email@example.com" v-model="employee.Email"/>
                                        <ErrorMessage name="email" />
                                    </div>
                                </li>
                                <li class="modal__inner-li-1 border_bot">
                                    <div class="modal__inner-body-phone-1 flo-lft pad-r25">
                                        <p class="modal__inner-title">Tài khoản ngân hàng</p>
                                        <input class="modal__inner-title-phone-1 pad-l10" type="text" placeholder="944147">
                                        
                                    </div>
                                    <div class="modal__inner-body-phone-2 flo-lft pad-r25">
                                        <p class="modal__inner-title">Tên ngân hàng</p>
                                        <input class="modal__inner-title-phone-2 pad-l10" type="text" placeholder="MB Bank">
                                    </div>
                                    <div class="modal__inner-body-phone-email flo-lft pad-r25">
                                        <p class="modal__inner-title">Chi nhánh</p>
                                        <input class="modal__inner-title-email pad-l10"  type="text" placeholder="Chi nhánh Hà Nội">
                                    </div>
                                </li>
                                <li class="modal__inner-li-button">
                                    <button class="modal__inner-li-button-cacel">Hủy</button>
                                    <button class="modal__inner-li-button-cat-2">Cất và thêm</button>
                                    <button class="modal__inner-li-button-cat">Cất</button>
                                </li>
                            </ul>
                        </div>
                        </Form> 
                        
                    </div>
                </div>
            </div>
    </div>
</template>
<script>
import { Form, Field, ErrorMessage  } from 'vee-validate';
import * as yup from 'yup';
export default {
    name:"EmployeeAdd",
    components:{
        Form,Field, ErrorMessage
    },
    props: {
    employeeInput: {
      type: Object,
    },
  },
  created() {
    this.employee = this.employeeInput;
  },
    methods: {
        onSubmit(values) {
            console.log(values)
        },
        CloseFormDetail(){
            this.isShow = false;
        },
        ShowFormEmployee(){
            this.isShow = true;
        }
        
    },
    data(){
        const schema = yup.object({
        code: yup.string().required("Mã Nhân Viên Bắt Buộc"),
        fullname: yup.string().required("Tên Nhân Viên Bắt Buộc"),
        cmnd: yup.string().required("CMND Nhân Viên Bắt Buộc"),
        title: yup.string().required("Chức Vụ Nhân Viên Bắt Buộc"),
        state: yup.string().required("Nơi Cấp Bắt Buộc"),
        address: yup.string().required("Địa Chỉ Nhân Viên Bắt Buộc"),
        phone: yup.string().required("Số Điện Thoại Nhân Viên Bắt Buộc"),
        email: yup.string().required("Email Nhân Viên Bắt Buộc"),
});
        return {
            isShow : true,
            schema
        }
    },
    watch: {
    employeeInput(newVal) {
      this.employee = newVal;
    },
  },

}
</script>
<style scoped>
    @import url(@/style/main.css);
</style>