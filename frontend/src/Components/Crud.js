import React from "react";
import { useForm } from "react-hook-form";

function Crud() {

    const { data, handleSubmit } = useForm();
    const onSubmit = data => {

        fetch('https://localhost:44367/api/todo', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json',

            },
            body: JSON.stringify({
                title: data.title,
                description: data.description
            })
        })
    }

    return (
           
        
           
    )
}

export default Crud;