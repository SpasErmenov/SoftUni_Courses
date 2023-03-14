import { useState, useEffect } from 'react';

import * as userService from './services/userService.js';

import { Footer } from "./components/Footer";
import { Header } from "./components/Header";
import { Search } from "./components/Search";
import './App.css';
import { UserList } from "./components/UserList";

function App() {
    const [users, setUsers] = useState([]);

    useEffect(() => {
        userService.getAll()
            .then(users => {
                setUsers(users);
            })
            .catch(err => {
                console.log('Error' + err);
            });
    }, []);

    const onUserCreateSubmit = async (e) => {
        //Stop automatic form submit
        e.preventDefault();
        
        //tak form data from DOM tree
        const formData = new FormData(e.currentTarget);

        const data = Object.fromEntries(formData);

        //send AJAX request to server
        const createdUser = await userService.create(data);
        
        //if successful add new user to the state
        setUsers(state => [...state, createdUser]);

        //Close dialog
    };

    const onUserUpdateSubmit = async (e, userId) => {
        //Stop automatic form submit
        e.preventDefault();
        
        //tak form data from DOM tree
        const formData = new FormData(e.currentTarget);

        const data = Object.fromEntries(formData);

        //send AJAX request to server
        const updatedUser = await userService.update(userId, data);
        
        //if successful add new user to the state
        setUsers(state => state.map(x => x._id === userId ? updatedUser : x));

        //Close dialog
    };

    const onUserDelete = async (userId) => {
        //Delete from server
        await userService.remove(userId);
        //Delete from state
        setUsers(state => state.filter(x => x._id !== userId));
    };

    return (
        <>
            <Header />

            <main className="main">
                <section className="card users-container">
                    <Search />

                    <UserList
                     users={users}
                      onUserCreateSubmit={onUserCreateSubmit}
                      onUserUpdateSubmit={onUserUpdateSubmit}
                      onUserDelete={onUserDelete}
                      />

                </section>

            </main>

            <Footer />
        </>

    );
}

export default App;
