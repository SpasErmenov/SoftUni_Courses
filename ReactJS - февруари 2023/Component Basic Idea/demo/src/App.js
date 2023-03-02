import './App.css';
import Counter from './components/Counter';
import Movie from './components/Movie';
import Timer from './components/Timer';

function App() {
    const movies = [
        {title: "Man of Steel", year: 2008, cast:['Henry Cavil', 'Russell Crow']},
        {title: "Harry poter", year: 2008, cast:['Daniel', 'Russell Crow']},
        {title: "3rd movie", year: 2008, cast:['someone', 'Russell Crow']}
    ];



    return (
        <div className="App">
            <h1>React Demo</h1>

            <Counter canReset/>

            <Timer start={5}/>

            <h1>Movie List</h1>

            <Movie
                title={movies[0].title}
                year ={movies[0].year}
                cast={movies[0].cast}
                isNew={false}
            />
        </div>
    );
}

export default App;
