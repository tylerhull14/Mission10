import logo from './bowlinglogo.png';

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="logo" height="400" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">
          {props.title}Marlin and Shark Bowling League Team Members
        </h1>
      </div>
    </header>
  );
}

export default Header;
