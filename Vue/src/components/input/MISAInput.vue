<template>
    <input :class="className" :type="mytype" :placeholder="myplaceholder"/>
</template>
<script>
export default {
    name: "MISAInput",
    props:{
        myplaceholder: String,
        className:{
            type: String,
            default: "input__normal",
        },
        mytype:{
            type: String,
            default: "text",
        }
    }
}
</script>
<style>
    @import url(./MInput.css);
</style>