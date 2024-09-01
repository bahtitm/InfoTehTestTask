function submitFormPost(urn,formId) {
    // Get the form element
    const form = document.getElementById(formId);
    
    // Create a FormData object from the form
    const formData = new FormData(form);
    
    // Convert FormData to a plain object
    const data = Object.fromEntries(formData.entries());
    
    // Convert the data object to a JSON string
    const jsonData = JSON.stringify(data);
    //const host= window.location;
    const host="https://localhost:7083"// window.location;
    // Send the POST request using fetch
    fetch(`${host}${urn}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: jsonData
    })
    .then(response => response.json()) // Assuming the server responds with JSON
    .then(data => {
        console.log('Success:', data);
    })
    .catch((error) => {
        console.error('Error:', error);
    });
}
function RemoveEntity(urn,Id) {
    
    //const host= window.location;
    const host="https://localhost:7083"// window.location;
    // Send the POST request using fetch
    fetch(`${host}${urn}/${Id}`, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json'
        }
        
    })
    .then(response => response.json()) // Assuming the server responds with JSON
    .then(data => {
        console.log('Success:', data);
    })
    .catch((error) => {
        console.error('Error:', error);
    });
}
