
function FileExtensionsGetter(){

const apiUrl = 'https://localhost:7083/api/FileExtensions'; 


async function populateSelectBox() {
    try {
        
        const response = await fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Network response was not ok');
        }

        
        const data = await response.json();
        

        
        const selectBox = document.getElementById('fileExtentionSelectBox');

      
        data.forEach(item => {
            const option = document.createElement('option');
            option.value = item.id; 
            option.textContent = item.type; 
            selectBox.appendChild(option);
        });
    } catch (error) {
        console.error('Error fetching data:', error);
    }
}


populateSelectBox();
}