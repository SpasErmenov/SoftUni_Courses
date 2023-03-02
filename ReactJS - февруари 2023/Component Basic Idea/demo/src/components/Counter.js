import { useState } from 'react';

const getTitle = (count) => {
    switch (count) {
        case 1:
            return 'First Blood';
        case 2:
            return 'Double Kill';
        case 3:
            return 'Triple Kill';
        case 4:
            return 'Quadra Kill';
        case 5:
            return 'Penta Kill';

        default:
            return 'Counter';
    }
};

const Counter = (props) => {
    const [counter, setCounter] = useState(0);
    //const [title, setTitle] = useState('Counter');

    const incrementCounterHandler = () => {
        setCounter((oldCounter) => oldCounter + 1);
    };
    const decrementCounterHandler = () => {
        setCounter((oldCounter) => oldCounter - 1);
    };
    const clearCounterHandler = () => {
        setCounter(0);
    };

    return (
        <div>
            <h3 style={{ fontSize: Math.max(counter, 1) + 'em' }}>
                {counter >= 6 ? 'Godlike' : getTitle(counter)}
                : {counter}
            </h3>

            <button onClick={decrementCounterHandler}>-</button>

            {props.canReset && <button onClick={clearCounterHandler}>Clear</button>}

            {counter < 10
                ? <button onClick={incrementCounterHandler}>+</button>
                : null
            }

        </div>
    )
};

export default Counter;