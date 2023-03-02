import {useState} from 'react';

const Timer = (props) => {

    const [seconds, setSeconds] = useState(props.start);

    //NOT good practice (useEffect is better)
    setTimeout(() => {
        //setSeconds(seconds + 1) //to set const value like (5)
        setSeconds(oldSeconds => oldSeconds + 1) //better way for variable changes
    },1000);
    
    return(
        <div>
            <h2>Timer</h2>
            Time: {seconds}s
        </div>
    );

};

export default Timer;