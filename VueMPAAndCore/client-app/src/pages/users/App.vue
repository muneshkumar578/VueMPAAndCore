
<template>
	<div id="app">
		<h1>App Users</h1>
		<div v-if="loading">
			<p>The users are being fetched...</p>
		</div>
		<p>Here is the list of users</p>
		<ul>
			<li v-for="user in users" :key="user.name">
				{{user.name}}&nbsp;{{user.email}}
			</li>
		</ul>
	</div>
</template>

<script>
	const axios = require('axios');
	export default {
		name: 'App',
		data: function () {
			return {
				loading: true,
				users: []
			}
			
		},

		mounted: function () {
			console.log('here');
			axios.get('/users/GetUsers')
				.then(res => {
					console.log(res);
					this.users = res.data;
					this.loading = false;
				})
				.catch(err => {
					console.log(err);
					this.loading = false;
				});
		}
	}
</script>
