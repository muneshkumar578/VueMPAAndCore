
<template>
	<div id="app">
		<h1>Products app</h1>
		<div v-if="loading">
			<p>The products are being fetched...</p>
		</div>
		<p>Here is the list of some products</p>
		<ul>
			<li v-for="product in products" :key="product.name">
				{{product.name}}&nbsp;{{product.price}}
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
				products: []
			}
			
		},

		mounted: function () {
			console.log('here');
			axios.get('/Products/GetProducts')
				.then(res => {
					console.log(res);
					this.products = res.data;
					this.loading = false;
				})
				.catch(err => {
					console.log(err);
					this.loading = false;
				});
		}
	}
</script>
