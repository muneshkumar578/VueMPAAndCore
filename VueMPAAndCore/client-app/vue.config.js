module.exports = {
    outputDir: "../wwwroot/client-app/",
    filenameHashing: false,
    pages: {
        'products': {
            entry: './src/pages/products/main.js',
            template: 'public/index.html',
            title: 'Products',
            chunks: ['chunk-vendors', 'chunk-common', 'index']
        },
        'users': {
            entry: './src/pages/users/main.js',
            template: 'public/index.html',
            title: 'Users',
            chunks: ['chunk-vendors', 'chunk-common', 'index']
        }
    }
}