/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Components/**/*.{razor,razor.cs}",
        "!./Components/**/_Imports.razor",
    ],
    theme: {
        extend: {},
    },
    plugins: [
        require("@tailwindcss/forms")({
            strategy: 'class',
        }),
    ],
}

