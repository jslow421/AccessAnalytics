<template>
    <div class="p-grid dashboard-ctr">
        <div class="p-col-2 left-nav">
            SIDE NAV
        </div>
        <div class="p-col-10 data-ctr">
            MAIN SECTION
        </div>
    </div>
</template>

<script>
    //import Axios from 'axios';

    export default {
        name: "Dashboard",
        data() {

        },
        methods: {

        }
    }
</script>

<style scoped lang="scss">
    .dashboard-ctr {
        > .left-nav {
            height: 100vh;
        }

        > .data-ctr {
            height: 100vh;
        }
    }
</style>