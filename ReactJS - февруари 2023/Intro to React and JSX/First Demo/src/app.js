const rootElement = document.getElementById('root');
const root = ReactDOM.createRoot(rootElement);
/*
const headingElement = React.createElement('h1', {}, 'Hello from React');
const headerElement = React.createElement('header', {}, headingElement)
console.log(headerElement);
*/

const headerElement = (
    <header>
        <h1>Hello from react!</h1>
        <h2>Slogan here</h2>
    </header>
)

root.render(headerElement);