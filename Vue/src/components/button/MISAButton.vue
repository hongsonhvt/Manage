<template>
    <div class="btn">
        {{ Title }}
    </div>
</template>
<script>
export default {
    name: "MisaButton",
    props:{
        title:{
            type: String,
            default: ""
        }
    }
}
</script>
<style>
    @import url(./Mbutton.css);
</style>