module.exports = {
    outputDir: "../wwwroot/client-app/",
    filenameHashing: false,
    pages: {
        'products': {
            entry: './src/pages/products/main.js',
            template: 'public/index.html',
            title: 'Retailer',
            chunks: ['chunk-vendors', 'chunk-common', 'index']
        }
    }
}