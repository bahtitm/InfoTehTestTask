function submitFormPost(urn,formId) {
    
    const form = document.getElementById(formId);  
    
    const formData = new FormData(form);
    
    const data = Object.fromEntries(formData.entries());
    
  
    const jsonData = JSON.stringify(data);
    console.log(jsonData);
    
    const host="https://localhost:7083"// window.location;
   
    fetch(`${host}${urn}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: jsonData
    })
    .then(response => response.json()) 
    .then(data => {
        console.log('Success:', data);
    })
    .catch((error) => {
        console.error('Error:', error);
    });
   
    document.location.href="/";
    
}
function RemoveEntity(urn,Id) {
    
    
    const host="https://localhost:7083"// window.location;
    
    fetch(`${host}${urn}/${Id}`, {
        method: 'DELETE',
        headers: {
            'Content-Type': 'application/json'
        }
        
    })
    .then(response => response.json()) 
    .then(data => {
        console.log('Success:', data);
        
    })
    .catch((error) => {
        console.error('Error:', error);
    });
   
    document.location.href="/";
}
function updateNameRequest(urn,name,id) {

    const data = {name:name,id:id}
    
    
    const jsonData = JSON.stringify(data);
    console.log(jsonData);
    
    const host="https://localhost:7083"// window.location;
    
    fetch(`${host}${urn}`, {
        method: 'PUT',
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
   
     document.location.href="/";
    
}
