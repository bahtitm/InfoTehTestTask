
function FileExtensionsGetter(){
// URL of the API endpoint
const apiUrl = 'https://localhost:7083/api/FileExtensions'; // Replace with your actual API endpoint

// Function to fetch data and populate the select box
async function populateSelectBox() {
    try {
        // Fetch data from the API
        const response = await fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        // Parse the JSON data
        const data = await response.json();
        

        // Get the select element
        const selectBox = document.getElementById('fileExtentionSelectBox');

        // Clear existing options (if any)
        //selectBox.innerHTML = '<option value="">Select an option...</option>';

        // Populate the select box with options from the fetched data
        data.forEach(item => {
            const option = document.createElement('option');
            option.value = item.id; // Adjust based on your data structure
            option.textContent = item.type; // Adjust based on your data structure
            selectBox.appendChild(option);
        });
    } catch (error) {
        console.error('Error fetching data:', error);
    }
}

// Call the function to populate the select box when the page loads
populateSelectBox();
}